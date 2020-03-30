<template>
	<div class="my_l">
		<header class="top_bar" style="margin-top:-60px;">
		    <a onclick="window.history.go(-1)" class="icon_back"></a>
		    <h3 class="cartname">京东注册</h3>
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
		            <a @click="regist()" class="btn_login">注册</a>
		        </div>
		        <div class="go_reg_box">
		            <router-link tag="span" to="/login">返回登录</router-link>
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
    methods:{
        regist(){
            if(!valdate(this.LoginName)){
                alert("请输入电话号!");
                return false;
            }
            if(!valdate(this.PassWord)){
                alert("请输入密码!");
                return false;
            }
            this.$http.post('/Register/JDRegister',{LoginName:this.LoginName,PassWord:this.PassWord}).then(res=>{
                    console.log(JSON.stringify(res));
                    var _data=res.data;
                    if(_data.Code=='200'){
                    alert(_data.Message);
                        this.$router.push('/login/'+this.LoginName);
                    }  
            }).catch(function(er){
                console.log(JSON.stringify(er));
                   var _state=er.response.status;
                      var _er=error.response.data;
                   if(_state==440){
                        alert(_er.ErrorMessage);
                   }
            });
        }
    }
}

function valdate(parameter){
    var check=true;
    if(parameter =="" || parameter==null || parameter==undefined){
        check=false;
    }
    return check;
}

</script>

<style>
    @import '../../assets/css/login.css';
</style>


