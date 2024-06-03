document.getElementById('contactForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const subject = document.getElementById('subject').value;
    const message = document.getElementById('message').value;

    if (subject && message) {
        alert(`Assunto: ${subject}\nMensagem: ${message}`);
        // Aqui você pode adicionar o código para enviar a mensagem ao servidor
    } else {
        alert('Por favor, preencha todos os campos.');
    }
});
