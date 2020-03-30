<template>
	<div class="home_h">
		 <header class="m_header">
                <div class="m_header_box" id="my_search">
                    <a href="#" class="icon_logo"></a>
                    <form action="#">
                        <span class="icon_search"></span>
                        <input type="search" class="search" placeholder="点击搜索" v-on:click="goSearch()">
                    </form>
                     <router-link to="/login" class="logo_btn" v-show="flage">登录</router-link>
                </div>
               
            </header>       
	</div>
</template>

<script>
export default {
    data(){
      return{
          flage:true
      }  
    },
    mounted(){
        this.fun();
    },
    methods:{
        fun(){
             if(window.sessionStorage.userInfo){
               this.flage=false;
             }
        },
        goSearch(){
            this.$router.push('/search')
        },
    }
}
</script>
