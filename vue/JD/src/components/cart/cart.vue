<template>
  <div id="my_cart">
      <cartHead/>
      <cartMain/>
      <cartFooter/>
  </div>
</template>


<script>
import cartHead from './cartHead';
import cartMain from './cartMain';
import cartFooter from './cartFooter';
//vuex 辅助函数 可以获取store里面的getter的值
import {mapGetters,mapActions} from 'vuex'//引用状态管理计算属性

export default {
    data(){
        return{
            msg:'购物车页面',
            sum:12
        }
    },
     mounted(){
            this.$store.dispatch('hideNav')
        },
        destroyed(){
            this.$store.dispatch('showNav')
        },
    computed:mapGetters(['count','isEvenOrOdd','cartData']),//引用状态管理计算属性
    methods:{  //第三种写法当本页面即有自己的方法也有，store里面的方法
        //...mapActions(['add','remove']), //es6的写法
        addShop(productId){  //添加商品数量
            this.$store.dispatch('addShop',productId);
        },
        reduceShop(productId){ //减少商品数量
            this.$store.dispatch('reduceShop',productId);
        }
    },
    components:{
        cartHead,//购物车头部
        cartMain,//购物车内容部分
        cartFooter//购物车底部
    }
}
</script>

<style>
    @import '../../assets/css/cart.css';
</style>
