<template>
	<div id="cate_left">
		 <div class="category_left">
	            <ul class="childbox">
	                <li :class="{active:num==index}" v-for="(item,index) in leftData" v-bind:key="index" @click="num=index">
	                	<router-link :to="'/catgory/'+item.id">
	                	    {{item.categoryName}}
	                	</router-link>
	                </li>
	               
	            </ul>
	        </div>
	</div>
</template>



<script>
export default {
    data(){
        return{
            leftData:[],
            num:0
        }
    },
    mounted:function(){
        this.getData();
    },
    methods:{
        getData(){
            this.$http.get('/Category/GetCategory').then(res=>{
                if(res.status=="200"){
                    this.leftData=res.data;
                }
            }).catch(function(error){
                console.log(error);
            });
        }
    }
}
</script>

<style scoped>
    .active{
        background-color: #f60;
    }
</style>
