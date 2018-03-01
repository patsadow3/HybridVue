import Vue from 'vue';
import Vuex from 'vuex'

Vue.use(Vuex);

export const store = new Vuex.Store({
  state: {
    count: 0
  },
  mutations: {
    increment(state) {
      state.count++
      //C#
      invokeCSharpAction(state.count);
    }
  }
});

console.log(externalStore = store);


//console.log(externalStore.state.count)
//To work with VUE in C#
//externalStore.commit('increment')
//function invokeCSharpAction(name){console.log(name)}
