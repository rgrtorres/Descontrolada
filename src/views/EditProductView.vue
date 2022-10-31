<script setup lang="ts">
import MenuView from '../views/header/MenuView.vue'
</script>

<template>
    <MenuView />

    <div class="container">
        <form action="" method="post">
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
                        <td><input type="text" class="form-control" value="Grão"></td>
                        <td><input type="text" class="form-control" value="R$ 15,00"></td>
                        <td><input type="text" class="form-control" value="Café em grão"></td>
                        <td><input type="number" class="form-control" value="7"></td>
                        <td>
                            <select class="form-control">
                                <option value="">Organico</option>
                                <option value="" selected>Inorgânico</option>
                            </select>
                        </td>
                    </tr>
                </tbody>
            </table>

            <button class="btn btn-primary m-2">Cadastrar</button>
        </form>
    </div>
</template>