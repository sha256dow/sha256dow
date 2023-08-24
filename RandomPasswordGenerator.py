import random
import string

def generate_random_password(length, include_uppercase, include_lowercase, include_digits, include_special_chars):
    valid_chars = ""
    
    if include_uppercase:
        valid_chars += string.ascii_uppercase
    if include_lowercase:
        valid_chars += string.ascii_lowercase
    if include_digits:
        valid_chars += string.digits
    if include_special_chars:
        valid_chars += string.punctuation
    
    if not valid_chars:
        print("Erro: Nenhum tipo de caractere selecionado.")
        return
    
    password = ''.join(random.choice(valid_chars) for _ in range(length))
    return password

def main():
    print("Bem-vindo ao Gerador de Senhas Aleatórias!")
    
    while True:
        length = int(input("\nComprimento da senha: "))
        include_uppercase = input("Incluir letras maiúsculas? (S/N): ").strip().lower() == "s"
        include_lowercase = input("Incluir letras minúsculas? (S/N): ").strip().lower() == "s"
        include_digits = input("Incluir dígitos? (S/N): ").strip().lower() == "s"
        include_special_chars = input("Incluir caracteres especiais? (S/N): ").strip().lower() == "s"
        
        generated_password = generate_random_password(length, include_uppercase, include_lowercase, include_digits, include_special_chars)
        print(f"\nSenha gerada: {generated_password}\n")
        
        another_password = input("Deseja gerar outra senha? (S/N): ").strip().lower()
        if another_password != "s":
            break
    
    print("Obrigado por usar o Gerador de Senhas Aleatórias!")

if __name__ == "__main__":
    main()
