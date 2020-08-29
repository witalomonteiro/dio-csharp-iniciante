namespace Revisao {
    public class Aluno {
        public string nome;
        public decimal nota;
        public void setNome(string n) {
            this.nome = n;
        }
        public string getNome() {
            return this.nome;
        }
        public void setNota(decimal nt) {
            this.nota = nt;
        }
        public decimal getNota() {
            return this.nota;
        }
    }
}