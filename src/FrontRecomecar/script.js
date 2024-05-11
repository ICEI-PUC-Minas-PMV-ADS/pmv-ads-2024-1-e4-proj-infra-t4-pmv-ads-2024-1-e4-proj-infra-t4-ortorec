

const url = "https://localhost:7109/api/Usuarios/Authenticate/authenticate"


async function login()
{
    document.getElementById("loginForm").addEventListener("submit", async (event) => {
        event.preventDefault(); // Evita o envio padrão do formulário

        const id = document.getElementById("usuarioId").value;
        const email = document.getElementById("email").value;
        const password = document.getElementById("password").value;

        try {
            const response = await fetch("https://localhost:7109/api/Usuarios/Authenticate/authenticate", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                "usuarioId": id,
                "email": email,
                "password": password
                })
            });

            if (response.ok) {
                // Autenticação bem-sucedida! Redirecione ou execute outra ação.
                console.log("Autenticado com sucesso!");
                window.location.href = "../index.html";
            } else {
                console.error("Erro na autenticação:", response.statusText);
            }
        } catch (error) {
            console.error("Erro na requisição:", error);
        }
    });
}


