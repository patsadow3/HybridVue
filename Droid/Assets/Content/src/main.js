import Vue from 'vue';
import app from './app.vue';
import { router } from './routes';
import { store } from './store';
import VueChatScroll from 'vue-chat-scroll'
Vue.use(VueChatScroll)

export default new Vue({
  el: '#app',
  render: c => c('app'),
  components: {
    app,
  },
  router,
  store
});
