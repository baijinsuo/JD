<template>
  <div class="mine_mm">
  <main class="mine_layout">
      <section class="mine_infos clearfix">
          <div class="mmm_info">
              <div class="user_icon">
                  <img src="../../assets/images/my_icon.jpg" alt="">
              </div>
              <div class="user_detal">
                  <p class="user_name">{{info.UserName}}</p>
                  <div class="reg">
                      <a href="#" class="reg_link">注册会员</a>
                      <div class="vip">
                      <span class="vip_icon">
                          <img src="../../assets/images/vip.png" alt="">
                      </span>
                          <a href="#">
                              立享PLUS特权 >
                          </a>
                      </div>
                  </div>
              </div>
              <div class="manage_account" @click="UpdaeInfo()">
                  <span>
                      修改信息
                  </span>
              </div>
          </div>
          <div class="yguanzhu_box">
              <ul class="gunzhuf">
                  <li class="item">
                      <a href="" class="item_link">
                          <span>0</span>
                          <span>关注的商品</span>
                      </a>
                  </li>
                  <li class="item">
                      <a href="" class="item_link">
                          <span>0</span>
                          <span>关注的店铺</span>
                      </a>
                  </li>
                  <li class="item">
                      <a href="" class="item_link">
                          <span>8</span>
                          <span>浏览记录</span>
                      </a>
                  </li>
              </ul>
          </div>
      </section>
      <section class="my_order_box">
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/my_order_icon.png" alt="">
                  <span>我的订单</span>
              </div>
              <div class="order_right">
                  <span>全部订单></span>
              </div>
          </div>
          <div class="order_bottom_box">
              <ul>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <img src="../../assets/images/waitpay.png" alt="" class="order_item_pic">
                          <span class="order_item_pay">待付款</span>
                      </a>
                  </li>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <img src="../../assets/images/wuliu.png" alt="" class="order_item_pic">
                          <span class="order_item_pay">待收货</span>
                      </a>
                  </li>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <img src="../../assets/images/tuihuan.png" alt="" class="order_item_pic">
                          <span class="order_item_pay">退换/售后</span>
                      </a>
                  </li>
              </ul>
          </div>
      </section>
      <section class="my_order_box">
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/mypackage.png" alt="">
                  <span>我的钱包</span>
              </div>
              <div class="order_right">
                  <span>></span>
              </div>
          </div>
          <div class="order_bottom_box">
              <ul>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <span style="margin-top: -5px;display: block">0</span>
                          <span class="order_item_pay">账户余额</span>
                      </a>
                  </li>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <span style="margin-top: -6px;display: block">0</span>
                          <span class="order_item_pay">优惠券</span>
                      </a>
                  </li>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <span style="margin-top: -6px;display: block">0</span>
                          <span class="order_item_pay">京豆</span>
                      </a>
                  </li>
                  <li class="order_item">
                      <a href="#" class="order_item_link">
                          <span style="margin-top: -6px;display: block">0</span>
                          <span class="order_item_pay">京东卡/E卡</span>
                      </a>
                  </li>
              </ul>
          </div>
      </section>
      <section class="my_order_box my_b_info">
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/baitiao1.png" alt="">
                  <span>京东白条</span>
              </div>
              <div class="order_right">
                  <span>白条还款、激活获礼包></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/baitiao2.png" alt="">
                  <span>客户服务</span>
              </div>
              <div class="order_right">
                  <span>返修/退换货、在线客服></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/bai3.png" alt="">
                  <span>会员plus</span>
              </div>
              <div class="order_right">
                  <span>PLUS绝密攻略></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/bai4.png" alt="">
                  <span>京东会员</span>
              </div>
              <div class="order_right">
                  <span>会员俱乐部></span>
              </div>
          </div>
      </section>
      <section class="my_order_box my_b_info">
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/huo1.png" alt="">
                  <span>京东火车票</span>
              </div>
              <div class="order_right">
                  <span>来京东轻松抢票></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/huo2.png" alt="">
                  <span>1元抢宝</span>
              </div>
              <div class="order_right">
                  <span>1元成就梦想></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/huo3.png" alt="">
                  <span>我的预约</span>
              </div>
              <div class="order_right">
                  <span>></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/huo4.png" alt="">
                  <span>我的必购码</span>
              </div>
              <div class="order_right">
                  <span>></span>
              </div>
          </div>
          <div class="order_top_box">
              <div class="order_left">
                  <img src="../../assets/images/huo5.jpg" alt="">
                  <span>应用推荐</span>
              </div>
              <div class="order_right">
                  <span>></span>
              </div>
          </div>
      </section>
  </main>
        <div class="pop" v-show="popStatus">
          <div class="pop_box">
              <div class="del_info">
                  暂无开通 
              </div>
              <div class="del_cancel" @click="CloseModel">
                  取消
              </div>
              <div class="del_ok" @click="CloseModel">
                  确定
              </div>
          </div>
        </div>
  </div>
</template>

<script>
export default {
  data () {
    return {
      info: '',
      popStatus:false
    }
  },
  mounted(){
    this.getInfo()
  },
  methods:{
    getInfo(){
      if(window.sessionStorage.userInfo){
        this.info = window.sessionStorage.userInfo;
      }else {
        this.$router.push('/login');
      }
    },
    UpdaeInfo(){
        this.popStatus=true;
    },
    CloseModel(){
        this.popStatus=false;
    }
  }
}
</script>

<style  scoped>
    .pop {
    position: fixed;
    left: 0;
    top: 0;
    right: 0;
    bottom: 0;
    background: rgba(0, 0, 0, .4);
    padding: 0 5%;
    z-index:11;
}

.pop .pop_box {
    width: 85%;
    height: 140px;
    background-color: #fff;
    border-radius: 8px;
    margin: 50% auto;
    padding: 0 5%;
}

.pop_box .del_info {
    text-align: center;
    line-height: 70px;
    font-size: 16px;
    color: #888888;
}

.pop_box .del_cancel {
    float: left;
    width: 35%;
    height: 35px;
    text-align: center;
    line-height: 35px;
    border: 1px solid #bfbfbf;
    border-radius: 4px;
    margin-right: 15%;
}

.pop_box .del_ok {
    float: left;
    width: 35%;
    height: 35px;
    text-align: center;
    line-height: 35px;
    border: 1px solid #bfbfbf;
    border-radius: 4px;
    background: #D8505C;
    color: #fff;
    margin-left: 15%;
}
</style>
