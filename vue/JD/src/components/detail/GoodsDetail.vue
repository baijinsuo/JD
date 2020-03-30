<template>
    <div class="goods_detail">
        <header class="top_bar">
            <a @click="goBack" class="icon_back"></a>
            <!-- <a onclick="window.history.go(-1)" class="icon_back"></a> -->
            <h3 class="cartname">商品详情</h3>
            <a href="#" class="icon_menu"></a> 
        </header>
        <main class="detail_box">
            <section class="banner_box">
                    <!-- 引用的公共轮播组件 -->
                    <Banner v-bind:imgDatas="goodsImagesList" v-if="flage"/>
            </section>
            <section class="product_info clearfix">
                <div class="product_left">
                    <p class="p_name">{{goodsData.productName}}</p>
                    <div class="product_pric">
                        <span>￥</span>
                        <span class="rel_price">{{goodsData.productPrice}}</span>
                        <span>.00</span>
                    </div>
                    <div class="product_right">
                        降价通知
                    </div>
                </div>

            </section>
            <section class="product_intro">
                <p class="pro_det">
                    {{goodsData.productDetail}}
                </p>
           </section>
        </main>
        <footer class="cart_d_footer">
            <div class="m">
                <ul class="m_box">
                    <li class="m_item">
                        <a href="" class="m_item_link">
                            <em class="m_item_pic"></em>
                            <span class="m_item_name">卖家</span>
                        </a>
                        <a href="" class="m_item_link">
                            <em class="m_item_pic two"></em>
                            <span class="m_item_name">关注</span>
                        </a>
                        <a href="" class="m_item_link">
                            <em class="m_item_pic three"></em>
                            <span class="m_item_name">购物车</span>
                        </a>
                    </li>
                </ul>
                <div class="btn_box clearfix" >
                    <a href="javascript:void(0)" class="buy_now" @click="addToCart()">加入购物车</a>
                    <a href="javascript:void(0)" class="buybuy">立即购买</a>
                </div>
            </div>
        </footer>
    </div>
</template>
<script>
import Banner from '../public/Banner'
export default{
    data(){
        return{
            num:0,
            goodsImagesList:[],
            goodsData:[],
            flage:false
        }
    },
    mounted(){
        this.getData(this.$route.params.id);
        this.play();
        this.$store.dispatch('hideNav'); //一进入这个页面就把底部导航隐藏
    },
    destroyed(){
         this.$store.dispatch('showNav'); //组件销毁的时候，设置底部导航显示
    },
    methods:{
            goBack(){
                window.history.go(-1)
            },
            getData(id){
                let self = this;
                self.$http.post('/Product/GetProductDetail',{Product_id:id}).then((res)=>{  
                    if(res.status =='200'){
                            self.goodsImagesList= res.data.imageUrl; 
                            self.goodsData=res.data;
                            self.flage=true;
                    }
                }).
                catch(function(error){
                      console.log(error);
                });
            },
            autoPlay:function(){
                this.num++;
                if(this.num == this.goodsImagesList.length){
                    this.num = 0;
                }
            },
            play:function(){
                setInterval(this.autoPlay,2000);
            },
            addToCart(){ //点击加入购物车 
                //将vue对象转换为普通对象，便于后期再购物车数量加减 JSON.parse(JSON.stringify(this.goodsData));
                let data=JSON.parse(JSON.stringify(this.goodsData));
                data.num=1;
                data.checked=false;
                this.$store.dispatch('addCart',data); //将当前详情的数据存入到vuex里面
                this.$router.push('/cart');//跳转路由
            }
        },
        components:{
            Banner
        }
}
</script>

<style>
    @import '../../assets/css/detail.css';
</style>