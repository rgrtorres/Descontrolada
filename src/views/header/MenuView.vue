<template>
    <div class="container">
        <nav class="navbar navbar-expand-lg bg-light">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Descontrolada</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                    aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <router-link to="/" class="nav-link">Home</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link to="/product/insert" class="nav-link">Insert</router-link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
</template>