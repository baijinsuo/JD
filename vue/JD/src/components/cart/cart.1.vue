<template>
    <div>
      <h2>{{msg}} </h2>
      <h3>{{$store.state.count}}</h3>
         <h3>计算属性{{count}}:{{isEvenOrOdd}}</h3>
        <button @click="$store.commit('add')">点击++,直接操作commit</button>
        <button @click="$store.commit('add1',10)">点击+10,直接操作commit</button><br><br><br>
        <button @click="add">dispach加1，操作的是action</button><br><br><br>
        <button @click="remove">dispach减1(大于3的时候才会出发方法)action</button><br><br><br>
        <button @click="addInfo">本页面测试添加方法</button><br><br><br>
        <!-- <ul>
            <li v-for="(item,index) in cartData" :key="index">{{item}}</li>
        </ul> -->

        <div>
            {{cartData}}
        </div>

    </div>
</template>

<script>

//vuex 辅助函数 可以获取store里面的getter的值
import {mapGetters,mapActions} from 'vuex'//引用状态管理计算属性

export default {
    data(){
        return{
            msg:'购物车页面',
            sum:12
        }
    },
    // computed:{
    //     num(){
    //         return this.$store.state.count;
    //     }
    // }
    computed:mapGetters(['count','isEvenOrOdd','cartData']),//引用状态管理计算属性
    // methods:{
    //     add(){
    //         this.$store.dispatch('add'); //此add进入的是store->index.js 的actions方法的add方法
    //     },
    //     remove(){
    //         this.$store.dispatch('remove')//此方法同上
    //     }
    // }
    //methods:mapActions(['add','remove']) //第二种写法

    //第三种写法当本页面即有自己的方法也有，store里面的方法
    methods:{
        ...mapActions(['add','remove']), //es6的写法
        addInfo(){
            alert("添加测试");
        }
    }
}
</script>
