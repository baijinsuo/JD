<template>
	<div class="my_l">
		<header class="top_bar" style="margin-top:-60px;">
		    <a onclick="window.history.go(-1)" class="icon_back"></a>
		    <h3 class="cartname">京东登录</h3>
		</header>
		<main class="user_login_box">
		    <div class="login_dialog">　
		        <div class="_username">
		            <input type="text" name="username" placeholder="请输入用户名" class="user_input" v-model="LoginName"/>
		        </div>
		        <div class="_username u_passwd">
		            <input type="password" name="password" placeholder="请输入密码" class="user_input" v-model="PassWord"/>
		        </div>

		        <div class="login_box">
		            <a @click="login()" class="btn_login">登录</a>
		        </div>
		        <div class="go_reg_box">
		            <!-- <router-link tag="span" to="/register">快速注册</router-link> -->
                    <span @click="register()">快速注册</span>
		        </div>
		    </div>
		</main>
	</div>
</template>
<script>
export default {
    data(){
        return{
            LoginName:'',
            PassWord:''
        }
    },
    mounted(){
         this.LoginName=this.$route.params.id;
    },
    methods:{
        login(){
          this.$http.post('/login/Login',{LoginName:this.LoginName,PassWord:this.PassWord}).then(res=>{
              console.log(JSON.stringify(res));
              var _data=res.data;
              if(_data.code=='200'){
                   window.sessionStorage.userInfo=_data.Data;
                this.$router.push('/home')
              }  
          }).catch(function(error){
              console.log(Json.stringify(error));
           var _state=error.response.status
            var _er=error.response.data;
            if(_state==440){
                 alert(_er.ErrorMessage);
            }
          });        
        },
        register(){
            this.$router.push('/register');
        }
    }
}
</script>

<style>
    @import '../../assets/css/login.css';
</style>


