async function register() {
    document.getElementById("registre-box").addEventListener("submit", async (event) => {
        event.preventDefault(); // Evita o envio padrão do formulário

        const nome = document.getElementById("nome").value;
        const email = document.getElementById("email").value;
        const password = document.getElementById("password").value;
        const passwordConfirm = document.getElementById("passwordConfirm").value;


            try {
                const response = await fetch("https://localhost:7109/api/Usuarios/PostUsuario", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify({
                    "usuarioId": 0,
                    "nome": nome,
                    "email": email,
                    "password": password,
                    "image": "string",
                    "tipoUsuario": 0
                })
                });
                if (response.ok) {
                    // Registro bem sucedido! Redirecione ou execute outra ação.
                    console.log("Registrado com sucesso!");
                    window.location.href = "sucessoRegistro.html";

                    window.localStorage.setItem('email', JSON.stringify(email));
                    window.localStorage.setItem('usuarioId', JSON.stringify(usuarioId));

                } else {
                    console.error("Erro no Registro:", response.statusText);
                }
            } catch (error) {
                console.error("Erro na requisição:", error);
            }
        });
    }   

