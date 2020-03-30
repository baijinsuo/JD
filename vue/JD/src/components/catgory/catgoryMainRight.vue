<template>
	<div id="cate_right">
		 <div class="category_right">
	            <div class="category_banner">
	                <a href="#">
	                    <img src="../../assets/images/banner_1.png" alt="">
	                </a>
	            </div>
	            <div class="category_detail">
	                <h3 class="category_n">Hot Category Goods</h3>
	                <ul>
	                    <li class="category_detail_item" v-for="item in RightData" :key="item.productId">
	                        <router-link :to="'/detail/'+item.id" class="category_detail_item_link">
	                            <img v-lazy="item.productImgUrl" alt="" class="category_detail_item_pic">
	                            <p class="category_detail_item_name">{{item.productName}}</p>
	                        </router-link>
	                    </li>
	                
	                </ul>
	            </div>
	        </div> 
	</div>
</template>
<script>
export default {
    data(){
        return{
            RightData:[]
        }
    },
    mounted:function(){
        if(this.$route.params.id)
        {
            this.getRightData(this.$route.params.id);
        }
    },
      watch:{
      //$router为vueRouter实例 $router.push()
      //$route 对象this.$route.params     query    name   
      $route(to,from){
          console.log('to'+to);
          if(to.params.id){
              this.getRightData(to.params.id);
          }
      } 
    },
    methods:{
        getRightData(id){
            this.$http.post('/Category/GetCategoryList',{categoryId:id}).then(res=>{
                if(res.status=="200"){
                    this.RightData=res.data;
                }
            }).catch(function(error){
                console.log(error)
            });
        }
    }
}
</script>
