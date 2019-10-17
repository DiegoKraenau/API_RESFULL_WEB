import Vue from 'vue'
import App from './App.vue'
import router from './router'
import 'bootstrap'; 
import 'bootstrap/dist/css/bootstrap.min.css';
import VueResource from 'vue-resource'
import LoadScript from 'vue-plugin-load-script';

Vue.config.productionTip = false

Vue.use(VueResource)

Vue.use(LoadScript);

Vue.loadScript("../assets/vendor/jquery/jquery.min.js")
Vue.loadScript("../assets/vendor/bootstrap/js/bootstrap.bundle.min.js")

Vue.loadScript("../assets/vendor/jquery-easing/jquery.easing.min.js")

Vue.loadScript("../assets/js/jqBootstrapValidation.js")
Vue.loadScript("../assets/js/contact_me.js")

Vue.loadScript("../assets/js/agency.min.js")

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
