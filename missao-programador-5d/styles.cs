* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    outline: none;
    font-family: 'Roboto', sans-serif;
}

body {
    background: linear-gradient(90deg, #7F00FF 0%, #E100FF 100%);
}

#botao-adicionar {
    background: #8052EC;
    border-radius: 5px;
    height: 40px;
    border: none;
    padding: 0 15px;
    color: #FFFFFF;
    font-size: 17px;
    cursor: pointer;
    float: right;
    font-weight: 700;
}

#botao-adicionar:hover {
    opacity: 0.8;
}

#botao-adicionar:active {
    opacity: 0.6;
}

.container {
    background: #FFFFFF;
    max-width: 541px;
    margin-bottom: 100px;
    border-radius: 5px;
    margin-top: 100px;
    margin-left: auto;
    margin-right: auto;
    padding: 30px 20px;
}

#input-principal {
    width: 342px;
    height: 40px;
    border: 2px solid rgba(209, 211, 212, 0.4);
    border-radius: 5px;
    padding-left: 10px;
}

#tarefas {
    width: 100%;
    list-style: none;
    margin-top: 60px;
}

.item-tarefa {
    background: #F2F2F2;
    box-shadow: 1px 4px 10px rgba(0, 0, 0, 0.2);
    border-radius: 5px;
    padding: 20px 45px;
    cursor: pointer;
    position: relative;
    margin-top: 30px;
}

.nome-tarefa {
    color: #000000;
    font-size: 15px;
}

.botao-delete {
    border: none;
    background: transparent;
    position: absolute;
    right: 0;
    top: 0;
    height: 100%;
    width: 40px;
    cursor: pointer;
    opacity: 0;
    transition: opacity 0.5s ease-in-out;
}

.fa-trash {
    color: red;
}

.botao-foguete {
    border: none;
    background: transparent;
    position: absolute;
    left: 0;
    top: 0;
    height: 100%;
    width: 40px;
    cursor: pointer;
    opacity: 0;
    transition: opacity 0.5s ease-in-out;
}

.fa-rocket {
    color: #4F0FC5;
}

.item-tarefa:hover .botao-delete {
    opacity: 1;
}

.item-tarefa:hover .botao-foguete {
    opacity: 1;
}

.concluido {
    background-color: #d4f88d;
    text-decoration: line-through;
}