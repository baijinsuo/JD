<template>
	<div class="home_m">
		 <main class="m_product">
                <section class="product_box">
                    <div class="product_top">
                        <a href="#" class="product_left">
                            <img src="../../assets/images/jd_skill.png" alt="" class="miaosha_icon">
                            <strong class="dianshu">六点场</strong>
                            <span class="time">00:21:43</span>
                        </a>
                    </div>
                    <div class="product_content">
                        <ul>
                            <li class="product_skill_item" v-for="(item,index) in homeDatas" :key="index">
                               <router-link :to="'/detail/'+item.id" class="product_skill_item_link">
                                    <img v-lazy="item.productImgUrl" alt="" class="product_skill_item_cion lazy-img-fadein">
                                    <p class="nowprice">
                                        <i style="text-decoration: none;font-style: normal;font-size: 12px">¥</i>
                                        <span class="now_price">{{item.productUprice}}</span>
                                    </p>
                                    <p class="oldprice">
                                        <i style="text-decoration: none;font-style: normal;font-size: 12px">¥</i>
                                        <del class="old_price">{{item.productPrice}}</del>
                                    </p>
                                </router-link>
                            </li>
                        
                        </ul>
                    </div>
                </section>
                <div class="left_share_quality_content clearfix">
                    <div class="share_quality">
                        <div class="share_quality_top">
                            <div class="share_title">
                                <p class="share_text">为你推荐</p>
                            </div>
                        </div>
                        <div class="share_quality_left not_eng_box">
                            <ul>
                                <li class="not_eng_item" v-for="(item,index) in mainDatas" :key="index">
                                       <router-link :to="'/detail/'+item.id" class="not_eng_link">
                                        <img v-lazy="item.productImgUrl" alt="" class="not_eng_pic lazy-img-fadein">
                                        <div class="not_eng_info">
                                            <p class="not_eng_title">{{item.productName}}</p>
                                            <p class="not_eng_text">
                                                <i style="text-decoration: none;font-style: normal;font-size: 12px">¥</i>
                                                <span class="more_info_price_txt">{{item.productPrice}}</span>
                                            </p>
                                        </div>
                                    </router-link>
                                </li>
                        
                            </ul>
                        </div>
                    </div>
                </div>
            </main>
	</div>
</template>


 <script>
export default {
    data(){
        return{
            homeDatas:[],
            mainDatas:[]
        }
    },
    mounted(){
        this.getDate();
    },
    methods:{
        getDate(){
            let self=this;
            self.$http.post('/Product/GetProduct').then(res=>{
                // console.log(JSON.stringify(res));
                if(res.status=='200'){
                    self.homeDatas.push(res.data[0]);
                    self.homeDatas.push(res.data[1]);
                    self.homeDatas.push(res.data[2]);
                    self.homeDatas.push(res.data[3]);
                    self.mainDatas=res.data;
                }
            }).catch(function(error){
                console.log(error);
            });
        }
    }
}
 </script>
