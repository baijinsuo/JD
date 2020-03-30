<template>
	<div class="home_n">
		<nav class="m_nav">
                <ul>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav0.png" alt="">
                            <span>京东超市</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav1.png" alt="">
                            <span>全球购</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav2.png" alt="">
                            <span>服装城</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav3.png" alt="">
                            <span>京东生鲜</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav4.png" alt="">
                            <span>京东到家</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav5.png" alt="">
                            <span>充值中心</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav6.png" alt="">
                            <span>惠赚钱</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav7.png" alt="">
                            <span>领券</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav8.png" alt="">
                            <span>物流查询</span>
                        </a>
                    </li>
                    <li class="nav_item" @click="shopOpen">
                        <a href="#" class="nav_item_link">
                            <img src="../../assets/images/nav9.png" alt="">
                            <span>我的关注</span>
                        </a>
                    </li>
                </ul>
            </nav>
        <div class="pop" v-show="popStatus">
          <div class="pop_box">
              <div class="del_info">
                  暂无开通...请点击下面商品! 
              </div>
              <div class="del_cancel" @click="closeModel">
                  取消
              </div>
              <div class="del_ok" @click="closeModel">
                  确定
              </div>
          </div>
        </div>
	</div>
</template>

<script>
export default {
    data(){
        return{
            popStatus:false
        }
    },
    methods:{
        shopOpen(){
            this.popStatus=true;
        },
        closeModel(){
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
