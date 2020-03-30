<template>
    <div>
        <div class="page-contaniner">
        <!--开屏广告-->
        <div class="count-down" v-show="adBack">
            <span class="jump" @click="jump()">点击跳转<b>{{n}}</b></span>
        </div>
        <!--主体-->
              <div class="login-content">
                    <h1 class="login-title">欢迎登录</h1>
                    <div class="panel">
                        <input type="text" class="mobile btn" 
                            placeholder="手机号码"  v-model="mobile.name"
                            @focus="handleFocus('mobile')"
                            @blur="handleBlur('mobile')" />
                        <p class="error-tip" v-show="mobile.errTip">输入内容不符合</p>
                    </div>
                    <div class="panel">
                        <input type="password" class="password btn" 
                                placeholder="登录密码"  v-model="password.name"
                                @focus="handleFocus('password')"
                                @blur="handleBlur('password')" />
                        <p class="error-tip" v-show="password.errTip">输入内容不符合</p>
                    </div>
                    <div class="panel">
                        <a class="btn-login btn login" @click="submit()">登录</a>
                    </div>
                    <div class="panel">
                        <a class="text">我要注册</a>
                        <a class="text">忘记密码</a>
                    </div>
                </div> 
        </div>
    </div>
</template>

<script>
export default {
    data(){
        return{
            n:5,
            adBack:true ,  //开屏广告   true显示
            timer:null,  //定时器
            mobile:{name:'',errTip:false},
            password:{name:'',errTip:false}
        }
    },
    //生命周期   挂载完成
    mounted:function(){
        this.fun();
    },
    methods:{
         fun:function(){
              this.timer =  setInterval(this.play,1000);
            },
            play:function(){
                this.n--;
                if(this.n ==0){
                    this.adBack = false;   //隐藏
                    clearInterval(this.timer);    //清除定时器
                }
            },
            jump:function(){
                 this.adBack = false;     //隐藏
                 clearInterval(this.timer);    //清除定时器
            },
            handleFocus:function(type){    //成为焦点
                if(type == 'mobile'){
                    this.mobile.errTip = false;    //错误信息 隐藏
                }else if(type == 'password'){
                    this.password.errTip = false;    //错误信息 隐藏
                } 
            },
            handleBlur:function(type){    //失去焦点
                if(type == 'mobile'&& this.mobile.name ==''){
                     this.mobile.errTip = true;    //错误信息 显示
                } else if(type == 'password'&& this.password.name ==''){
                    this.password.errTip = true;    //错误信息 显示
                }
            },
            submit:function(){
                if(this.mobile.name =='' || this.password.name =='') {
                    alert('错误信息')
                }else {
                    //请求
                }
            }
    }
}
</script>


<style scoped>
    @import '../../assets/css/common.css';
</style>




