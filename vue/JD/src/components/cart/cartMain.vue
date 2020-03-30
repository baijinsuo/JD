<template>
  <div>
    <div class="cart_content clearfix" v-for="(item,index) in cartData" :key="index">
            <div class="cart_shop clearfix">
                <!-- <div class="cart_check_box">
                    <div class="check_box"> 

                    </div>
                </div> -->
                <div class="shop_info clearfix">
                      <input type="checkbox" v-model="item.checked" @change="curCheckChange()"/>
                    <img src="../../assets/images/buy-logo.png" alt="" class="shop_icon">
                    <!-- <span class="shop_name">{{item.shop_name}}</span> -->
                </div>
                <div class="cart_free clearfix">
                    <span class="free_tip">优惠券></span>
                </div>
            </div>
            <div class="cart_item">
                <!-- <div class="cart_item_box">
                    <div class="check_box1">
                             <input type="checkbox"/>
                    </div>
                        
                </div> -->
                <div class="cart_detial_box clearfix">
                    <a href="#" class="cart_product_link">
                        <img v-lazy="item.productImgUrl" alt="">
                    </a>
                    <div class="item_names">
                        <a href="#">
                            <span>{{item.productName}}</span>
                        </a>
                    </div>
                    <div class="cart_weight">
                        <i class="my_weigth">重量:0.45kg</i>
                        <span class="my_color">颜色:AT800/16</span>
                    </div>
                    <div class="cart_product_sell">
                        <span class="product_money">￥<strong class="real_money">{{item.productPrice}}</strong>.00</span>
                        <div class="cart_add clearfix">
                            <span class="my_add" @click="addShop(item.productId)">+</span>
                            <input type="tel" value="item.productId" class="my_count" v-model="item.num">
                            <span class="my_jian" @click="reduceShop(item.productId)">-</span>
                        </div>
                    </div>
                    <div class="cart_del clearfix" @click="delCart(item.productId)">
                        <div class="del_top" >
                        </div>
                        <div class="del_bottom">
                        </div>
                    </div>
                </div>
            </div>
          
        </div>


     <div class="pop" v-show="popStatus">
          <div class="pop_box">
              <div class="del_info">
                  确定要删除该商品吗？ 
              </div>
              <div class="del_cancel" @click="delCancel">
                  取消
              </div>
              <div class="del_ok" @click="removeShop()">
                  确定
              </div>
          </div>
        </div>

  </div>
</template>


<script>

//vuex 辅助函数 可以获取store里面的getter的值
import {mapGetters,mapActions} from 'vuex'//引用状态管理计算属性

export default {
    data(){
        return{
            popStatus:false,
            curId:''
        }
    },
    computed:mapGetters(['count','isEvenOrOdd','cartData']),//引用状态管理计算属性
    methods:{  //第三种写法当本页面即有自己的方法也有，store里面的方法
        //...mapActions(['add','remove']), //es6的写法
        addShop(productId){  //添加商品数量
            this.$store.dispatch('addShop',productId);
        },
        reduceShop(productId){ //减少商品数量
            this.$store.dispatch('reduceShop',productId);
        },
        removeShop(productId){ //移除商品
            this.popStatus = false;
            this.$store.dispatch('removeShop',this.curId);
        },
        delCart:function(id){   //删除
            this.popStatus = true;
            this.curId = id;
        },
        delCancel:function(){   //取消
            this.popStatus = false;
        },
        curCheckChange(){  //单个复选框 选中 非选中状态
            this.$store.dispatch('curCheckChange');
        }
    }
}
</script>

<style>
    @import '../../assets/css/cart.css';
</style>



<style scoped>
    .check_box1 {
    display: block;
    width: 30px;
    height: 20px;
    background: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGQAAADICAYAAAAePETBAAAAGXRFW…EIIAQhgBCEAEIQAggBhCAEEIIQQAhCACEIAYQAQjKQ/wQYAM7Lvnv8amgCAAAAAElFTkSuQmCC) no-repeat;
    background-size: 50px 100px;
    background-position: 0 0;
    position: absolute;
    left: 6px;
    top: 45px;
}
</style>
