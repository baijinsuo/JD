<template>
    <div class="user_i">
        <mineHead/>
        <mineMain/>
    </div>
</template>
<script>
import mineHead from './mineHead';
import mineMain from './mineMain';
export default {
    data(){
        return{
            msg:'个人信息页面'
        }
    },
    components:{
        mineHead,
        mineMain
    }
}
</script>

<style>
    @import '../../assets/css/mine.css'
</style>
