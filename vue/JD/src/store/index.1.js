import Vue from 'vue'//引用vue文件
import Vuex from 'vuex'//引用vuex文件
import { relative } from 'path';

Vue.use(Vuex);//全局注册使用

//定义状态属性，state 名字不可以写错
var state={
    count:1,
    name:'白金索-vuex',
    name1:'state 状态属性',
    name2:'actions 管理mutations',
    name3:' mutations 改变状态的值',
    name4:'getters 状态管理计算属性',
    IsShow:true,
    cartDate:[],  ///购物车的数据
    checkAllState:false //全选状态
}

//管理mutations
var actions={
    add({commit,state}){
        commit('add');
    },
    remove({commit,state}){
        if(state.count > 3){ //判断状态里面的count值，大于3的时候出发 mutations ->remove方法
             commit('remove');
        }
    },
    hideNav({commit}){ //控制底部导航隐藏
        commit('HIDENAV');
    },
    showNav({commit}){ //控制底部导航显示
        commit('SHOWNAV');
    },
    addCart({commit},data){  //添加购物车信息
        commit('ADDCART',data);
    },
    addShop({commit},productId){ //添加商品数量
        commit('ADDSHOP',productId);
    },
    reduceShop({commit},productId){//减少商品数量
        commit('REDUCESHOP',productId);
    },
    removeShop({commit},productId){//移除商品
        commit('REMOVESHOP',productId);
    },
    
    checkAllChange({commit, state}) {   //全选状态
        commit('CHECKALLCHANGE')
    },
    curCheckChange({commit, state}) {   //当前状态
        commit('CURCHECKCHANGE')
    }
}

//改变状态的值 mutations名字不能写错
var mutations={
    add(state){
        state.count++;
    },
    add1(state,sum){//sum表示传递过来的参数
        state.count+=sum;
    },
    remove(state){
        state.count-=1;
    },
    HIDENAV(state){
        state.IsShow=false;
    },
    SHOWNAV(state){
        state.IsShow=true;
    },
    ADDCART(state,data){ //添加到购物车  state 
        console.log(data);
        if(state.cartDate.length > 0){ 
            var n=0;
            for(var i=0;i<state.cartDate.length;i++){
                if(state.cartDate[i]['productId']==data.productId){
                    state.cartDate[i]['num']++;
                    state.cartDate[i]['productPrice'] + data.productPrice;
                    n++;
                }
            }
            if(n==0)
            {
                state.cartDate.push(data);
            }
        }else {
            state.cartDate.push(data);
        }
    },
    ADDSHOP(state,productId){ //添加商品数量
        var _cartData=state.cartDate;
        for(var i=0;i<_cartData.length;i++){
            if(_cartData[i]['productId']==productId){
                _cartData[i]['num']++;
            }
        }
    },
    REDUCESHOP(state,productId){ //减少商品数量
        var _cartData1=state.cartDate;
        for(var i=0;i<_cartData1.length;i++){
            if(_cartData1[i]['productId']==productId){
                if( _cartData1[i]['num'] >1){
                    _cartData1[i]['num']--;
                }
              
            }
        }
    },
    REMOVESHOP(state,productId){ //删除商品
        var _cartData2=state.cartDate;
        for(var i=0;i<_cartData2.length;i++){
            if(_cartData2[i]['productId']==productId){
                _cartData2.splice(i,1);
                break;
            }
        }
    },
    CHECKALLCHANGE(state) {    //全选状态 全选、反选
        state.checkAllState = !state.checkAllState;
        for(var i=0;i<state.cartDate.length;i++){
            state.cartDate[i]['checked']= state.checkAllState;
        }
    },
    CURCHECKCHANGE(state) {   //单个复选框的选中状态改变全选反选的状态
        var select = state.cartDate.filter(function(v){
            return v.checked ==true;
        });
        //匹配选中状态与lists的长度
        select.length ==state.cartDate.length ?  state.checkAllState = true : state.checkAllState = false;
    }
}

//状态管理计算属性 getters 名字不能写错
var getters={
    count(state){
        return state.count;
    },
    isEvenOrOdd(state){
        return state.count % 2 ?'基数':'偶数';
    },
    IsShow(state){ //计算属性判断导航显示隐藏
        return state.IsShow;
    },
    cartData(state){  //返回加入购物车的数据
        return state.cartDate;
    },
    shopTotal(state){  //返回商品单价*商品数量的总金额
        var select = state.cartDate.filter(function(v){
            return v.checked ==true;
        });
        if(select.length>0){
            return select.reduce(function(total,cur){    //total 计算结束后的返回值   cur当前元素
                return total+cur.productPrice*cur.num;
            },0)
        }else{
            return 0;
        } 
    },
    checkAllState(state) {    //全选的状态
        return state.checkAllState
    }
}
//导出
export default new Vuex.Store({
    state, //相当于vue的data
    mutations, //改变状态值
    getters, //相当于vue的计算属性
    actions //相当于vue的methods方法，管理mutations
});




