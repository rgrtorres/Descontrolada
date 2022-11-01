<script setup lang="ts">
import MenuView from '../views/header/MenuView.vue'
</script>

<template>
    <MenuView />

    <main>
        <div class="container">
            <table class="table sm">
                <thead>
                    <tr>
                        <th>Produto</th>
                        <th>Tipo</th>
                        <th>Ação</th>
                    </tr>
                </thead>
    
                <tbody>
                    <tr v-for="product in products" v-bind:key="product.id">
                        <td>{{ product.name }}</td>
                        <td>{{ product.type }}</td>
                        <td>
                            <router-link :to="{name: 'editProduct', params: {id: product.id}}">Editar</router-link> / <router-link to="product/delete/5">
                                Deletar</router-link>
                        </td>
                    </tr>
                </tbody>
            </table>
    
            <nav aria-label="Page navigation example">
                <ul class="pagination">
                    <li class="page-item">
                        <a class="page-link" href="#" aria-label="Previous">
                            <span aria-hidden="true">&laquo;</span>
                        </a>
                    </li>
                    <li class="page-item"><a class="page-link" href="#">1</a></li>
                    <li class="page-item"><a class="page-link" href="#">2</a></li>
                    <li class="page-item"><a class="page-link" href="#">3</a></li>
                    <li class="page-item">
                        <a class="page-link" href="#" aria-label="Next">
                            <span aria-hidden="true">&raquo;</span>
                        </a>
                    </li>
                </ul>
            </nav>
        </div>
    </main>
</template>

<script lang="ts">
import axios from 'axios'

export default {
    data() {
        return {
            products: [],
        }
    },
    methods: {
        async getProducts() {
            const { data } = await axios.get('https://localhost:7020/api/Products')
           
            this.products = data;
        }
    },
    mounted() {
        this.getProducts();
    }
}
</script>