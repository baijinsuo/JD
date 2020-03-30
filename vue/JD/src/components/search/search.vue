<template>
	<div class="search_page">
		<div class="h_layout">
			<div class="search_ma">
			<header class="top_bar">
					<a @click="goBack" class="icon_back"></a>
					<form  class="goods_search">
						<!--监听input的输入值变化事件-->
						<input type="search" 
							class="goods_search_content" 
							placeholder="搜索" 
							v-model="keyword" 
							@input="goSearch()">
					</form>
					<a href="#" class="icon_menu"></a>
			</header>
                <section class="search_condition">
					<ul>
						<li>
							<span class="all">全部</span>
							<em class="all_icon"></em>
						</li>
						<li>
							<span>销量</span>
							<em class="price_up" @click="getByPriceHotAsc()"></em>
							<em class="price_down" @click="getByPriceHotDesc()"></em>
						</li>
						<li class="p_price">
							<span>价格</span>
							<em class="price_up" @click="getByPriceHotAsc()"></em>
							<em class="price_down" @click="getByPriceHotDesc()"></em>
						</li>
						<li>
							<span>筛选</span>
							<em class="price_up"></em>
							<em class="price_down" ></em>
						</li>
					</ul>
				</section>
				<main class="main_goods_box">
					<ul>
						<li class="goods_item" v-for="(item,index) in searchData" :key="index">
							<router-link :to="'/detail/'+item.productId" class="goods_item_link">
								<img :src="item.productImgUrl" alt="" class="goods_item_pic">
								<div class="goods_right">
									<div class="pp_name">
										<span>
											{{item.productName}}
										</span>
									</div>
									<div class="price_box">
										<span>￥</span>
										<span>{{item.productUprice}}</span>
										<span>.00</span>
									</div>
									<div class="pinglun_box">
										<span>{{item.productCommentNum}}条评价</span>
										<span>{{item.shopName}}</span>
									</div>
								</div>
							</router-link>
						</li>
					</ul>
				</main>

		</div>
		</div>
	</div>
</template>

<script>
export default {
    data(){
        return{
			 keyword:'',
			 PriceUp:0,
			 productHot:0,
             searchData:[]
        }    
    },
    methods:{
        goBack(){
			this.$router.push('/home')
			//window.history.go(-1);
        },
        goSearch(){
            let self=this;
            this.$http.post('/Product/GetSearchProduct',{productName:this.keyword,productUprice:this.PriceUp,productHot:this.productHot}).then(res=>{
				if(res.status=="200"){
					self.searchData=res.data;
				}
            }).catch(function(error){
                console.log(error);
            });
		},
		getByPriceUp(){//升序
			this.PriceUp=1;
			this.goSearch();
		},
		getByPriceDown(){//降序
			this.PriceUp=0;
			this.goSearch();
		},
		getByPriceHotAsc(){//升序
			this.productHot=1;
			this.goSearch();
		},
		getByPriceHotDesc(){//降序
			this.productHot=0;
			this.goSearch();
		}
    },   
     components:{

    }
}
</script>

<style scoped>
	@import '../../assets/css/searchpage.css';
</style>









