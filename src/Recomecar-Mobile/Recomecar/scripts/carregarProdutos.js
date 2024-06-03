async function carregarProdutos()
{
    try {
        const response = await fetch("https://localhost:7109/api/Usuarios/Authenticate/authenticate", {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            },
        });

        if (response.ok) {
               // Autenticação bem-sucedida! Redirecione ou execute outra ação.
              console.log("Busquei!");
        } else {
              console.error("Erro na Busca:", response.statusText);
        }
    } catch (error) {
         console.error("Erro na requisição:", error);
    }
};
