<script setup lang="ts">
import MenuView from '../views/header/MenuView.vue'
</script>

<template>
    <MenuView />

    <div class="container">
        <form id="insertForm" @submit="createProduct">
            <p v-if="errors.length">
                <b>Verifique todos os campos por favor!</b>
            <ul>
                <li v-for="error in errors">{{ error }}</li>
            </ul>
            </p>

            <table class="table">
                <thead>
                    <tr>
                        <th>Produto</th>
                        <th>Preço</th>
                        <th>Descrição</th>
                        <th>Quantidade</th>
                        <th>Tipo</th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td><input type="text" v-model="name" name="name" class="form-control"></td>
                        <td><input type="text" v-model="price" name="price" class="form-control"></td>
                        <td><input type="text" v-model="description" name="description" class="form-control">
                        </td>
                        <td><input type="number" v-model="qtd" name="qtd" class="form-control" min="1"></td>
                        <td>
                            <select class="form-control" v-model="type" name="type">
                                <option value="Orgânico">Orgânico</option>
                                <option value="Não Orgânico">Inorgânico</option>
                            </select>
                        </td>
                    </tr>
                </tbody>
            </table>

            <button class="btn btn-primary m-2">Cadastrar</button>
        </form>
    </div>
</template>

<script lang="ts">
export default {
    name: "insertForm",
    data() {
        return {
            name: null,
            description: null,
            price: null,
            qtd: null,
            type: null,
            errors: []
        }
    },
    methods: {
        async createProduct(e) {

            e.preventDefault();
            this.errors = [];

            if (!this.name) {
                this.errors.push("O nome é obrigatório.");
            }
            
            if (!this.description) {
                this.errors.push("A descrição é obrigatória!");
            }
            
            if (!this.price) {
                this.errors.push("O preço é obrigatório!");
            }

            if (this.qtd <= 0) {
                this.errors.push("A quantidade precisa ser maior que 0.");
            }

            if (this.type <= 0) {
                this.errors.push("O tipo é obrigatório!");
            }
            
            else {
                const data = {
                    name: this.name,
                    description: this.description,
                    price: this.price,
                    qtd: this.qtd,
                    type: this.type
                }

                const dataJson = JSON.stringify(data)

                const req = await fetch("https://localhost:7020/api/Products", {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: dataJson
                })

                const res = await req.json()

                console.log(res)
                alert('Inserido com sucesso!')

                this.$router.push({path: '/'})
            }
        }
    }
}
</script>