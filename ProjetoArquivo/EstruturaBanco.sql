﻿CREATE DATABASE PROJETOARQUIVO
GO

USE PROJETOARQUIVO

CREATE TABLE DADOS_ARQUIVO(
	Codigo INT PRIMARY KEY NOT NULL,
    Descricao VARCHAR(30),
    Situacao BIT,
    Data DATE
)