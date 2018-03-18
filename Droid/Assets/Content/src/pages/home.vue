<template>
  <div id="home">  

  <ul class="messages" v-chat-scroll>
      <li
        v-bind:class="{ 'input-message': todo.isInput, 'output-message': todo.isOutput }"
        v-for="(todo, index) in todos"
        v-bind:key="todo.id"
        v-bind:title="todo.title"
        v-on:remove="todos.splice(index, 1)">{{todo.title}}
        </li>
    </ul>

<div class="enter-send-message">
    <input
      class="enter-message"
      v-model="newTodoText"
      v-on:keyup.enter="addNewTodo"
      placeholder="Send message">
    <button
       class="send-message"
      v-on:click="addNewTodo">Send message</button>
  </div>


  <div class="navbar">
    <a href="#home" class="active"><div class="icons" /></a>
    <a href="#news"><div class="icons" /></a>
    <a href="#contact"><div class="icons" /></a>
  </div>

  </div>
</template>

<script>
 export default {
  methods: {
    addNewTodo: function () {
      if(this.newTodoText!=''){
        this.todos.push({
          id: this.nextTodoId++,
          title: this.newTodoText,
          isOutput: true,
          isInput: false
        })
      }
      this.newTodoText = ''
    }
  },
    data() {
             return {
     newTodoText: '',
    todos: [
      {
        id: 1,
        title: 'Do the dishes',
        isInput: true,
        isOutput: false
      },
      {
        id: 2,
        title: 'Take out the trash',
        isInput: true,
        isOutput: false
      },
      {
        id: 3,
        title: 'Mow the lawn',
        isInput: false,
        isOutput: true
      }
    ],
    nextTodoId: 4
       };
 }
 }

</script>

<style scope>
@import './../css/home.css';
</style>