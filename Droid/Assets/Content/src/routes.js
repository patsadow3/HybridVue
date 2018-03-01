import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from './pages/home.vue';

Vue.use(VueRouter)

const routes = [
  { path: '/', component: Home },
  { path: '/home', component: Home }
]

export const router = new VueRouter({
  routes 
})

