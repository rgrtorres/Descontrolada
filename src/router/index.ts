import { createRouter, createWebHistory } from 'vue-router'

//** Views
import MainView from '@/views/MainView.vue'
import InsertProductView from '@/views/InsertProductView.vue'
import EditProductView from '@/views/EditProductView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: MainView
    },
    {
      path: '/product/insert',
      name: 'insertProduct',
      component: InsertProductView,
    },
    {
      path: '/product/edit/:id',
      name: 'editProduct',
      component: EditProductView,
    }
  ]
})

export default router
