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
                        <!-- <th>Ação</th> -->
                    </tr>
                </thead>

                <tbody>
                    <tr v-for="product in products" v-bind:key="product.id">
                        <td>{{ product.name }}</td>
                        <td>{{ product.type }}</td>
                        <!-- <td>
                                <router-link :to="{ name: 'editProduct', params: { id: product.id } }">Editar
                                </router-link> / <router-link to="product/delete/5">
                                    Deletar</router-link>
                            </td> -->
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

                    <li class="page-item" v-for="n in totalPage" v-bind:key="n">
                        <a class="page-link" href="#">{{ n }}</a>
                    </li>

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
            offset: 0,
            totalPerPage: 5,
            totalPage: 0,
        }
    },
    methods: {
        async getProducts() {
            const { data } = await axios.get('https://localhost:7020/api/Products')

            this.products = data;
            this.totalPage = Math.ceil(this.products.length / this.totalPerPage);
        }
    },
    mounted() {
        this.getProducts();
    }
}
</script>