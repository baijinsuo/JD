<template>
  <div id="app">
    <router-view/>
    <NavBottom v-show="IsShow"/>
  </div>
</template>

<script>
import NavBottom from './components/NavBottom'
import {mapGetters} from 'vuex'

export default {
  name: 'App',
  components:{
    NavBottom
  },
  computed:mapGetters(['IsShow'])
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
