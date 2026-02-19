from fastapi import FastAPI

# 1. Criamos a "instância" da API
app = FastAPI()

# Vamos criar um "banco de dados" falso (uma lista de dicionários)
db_termos = [
    {"termo": "API", "definicao": "Interface de Programação de Aplicações"},
    {"termo": "Frontend", "definicao": "A parte visual de um site"}
]

# 2. Rota Raiz (Apenas para teste)
@app.get("/")
def home():
    return {"mensagem": "Minha API de Python está rodando!"}

# 3. Rota para Listar todos os termos (GET)
@app.get("/termos")
def listar_termos():
    return db_termos

# 4. Rota para Adicionar um novo termo (POST)
@app.post("/termos")
def criar_termo(novo_termo: dict):
    db_termos.append(novo_termo)
    return {"mensagem": "Termo adicionado com sucesso!", "item": novo_termo}

@app.get("/termos/{nome_do_termo}")
def buscar_termo(nome_do_termo: str):
    for item in db_termos:
        if item["termo"].lower() == nome_do_termo.lower():
            return item
    return {"erro": "Termo não encontrado"}