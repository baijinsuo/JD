<template>
	<div class="cart_fo">
		<footer class="cart_footer">
		    <div class="all_check_box">
		        <!-- <div class="check_box">
				
		        </div> -->
				<input type ="checkbox" v-model="checkAllState" @change="checkAllChange()"/>
		        <span>全选</span>
		    </div>
		    <div class="count_money_box">
		        <div class="heji">
		            <strong>合计:</strong> 
		            <strong>￥</strong>
		            <strong>{{shopTotal.toFixed(2)}}</strong>
		        </div>
		        <div class="total_money clearfix">
		            <span>总额:</span>
		            <i>￥</i>
		            <span>{{shopTotal.toFixed(2)}}</span>
		            <span>立减:</span>
		            <i>￥</i>
		            <span>0.00</span>
		        </div>>
		            <a href="#" class="go_pay">
		                <span>去计算(1)</span>
		            </a>
		    </div>
		</footer>
	</div>
</template>
<script>
	import {mapGetters} from 'vuex'
	export default {
		computed:{
	      ...mapGetters(['shopTotal','checkAllState'])  //checkAllState 全选 、反选的状态 true false
        },
       methods:{
			checkAllChange(){
				this.$store.dispatch('checkAllChange');  //点击全选/反选
			}
		}
	}
</script>