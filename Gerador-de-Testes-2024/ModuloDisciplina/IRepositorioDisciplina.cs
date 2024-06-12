﻿using GeradorDeTestes2024.ModuloDisciplina;

namespace GeradorDeTestes2024.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novaDisciplina);
        bool Editar(int id, Disciplina disciplinaEditada);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int id);
        List<Disciplina> SelecionarTodos();
    }
}
