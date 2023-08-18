

# Aplicação de Controle de Consultório - Windows Forms 

Este repositório contém uma aplicação Windows Forms desenvolvida para o controle de um consultório médico. A aplicação permite visualizar médicos, pacientes e consultas agendadas, além de possibilitar o cadastro de novos pacientes e agendamentos de consultas. A arquitetura da aplicação segue uma abordagem de 4 camadas: acesso ao banco de dados, camada de apresentação, transferência de objetos (DTO) e regra de negócios.

## Funcionalidades

A aplicação oferece as seguintes funcionalidades:

- Listagem de médicos cadastrados.
- Listagem de pacientes cadastrados.
- Listagem de consultas agendadas.
- Cadastro de novo paciente.
- Agendamento de novas consultas.

## Arquitetura de 4 Camadas

### 1. Camada de Acesso a Banco de Dados

Nesta camada, a aplicação interage com um banco de dados relacional SQL Server para persistir e recuperar informações. Foram desenvolvidas stored procedures para realizar operações no banco de dados, garantindo uma separação adequada entre a lógica de acesso aos dados e as demais camadas.

### 2. Camada de Apresentação

A camada de apresentação é responsável por criar a interface do usuário usando Windows Forms. Ela exibe médicos, pacientes e consultas agendadas em telas apropriadas. Os usuários podem interagir com a interface para cadastrar novos pacientes, agendar consultas e visualizar informações.

### 3. Camada de Transferência de Objetos (DTO)

Os Data Transfer Objects (DTOs) são usados para transferir dados entre as camadas. Isso ajuda a minimizar o acoplamento entre elas e melhora a organização do código. Os DTOs encapsulam os dados necessários para as operações, evitando o tráfego excessivo de informações.

### 4. Camada de Regra de Negócios

Nesta camada, as regras de negócios da aplicação são implementadas. Aqui, a lógica é definida para validações, cálculos e manipulações necessárias para garantir a integridade dos dados e o funcionamento correto da aplicação.

## Banco de Dados Relacional e Stored Procedures

A aplicação interage com um banco de dados relacional SQL Server, contendo três tabelas principais:

1. Tabela `Medicos`: Armazena informações sobre os médicos cadastrados.
2. Tabela `Pacientes`: Armazena informações sobre os pacientes cadastrados.
3. Tabela `Consultas`: Mantém o registro das consultas agendadas, relacionando médicos e pacientes.

Foram criadas stored procedures no banco de dados para lidar com a manipulação dessas tabelas, garantindo uma abstração adequada e facilitando a comunicação com a aplicação.

## Configuração do Ambiente

1. Clone este repositório para o seu computador.
2. Certifique-se de ter o .NET Framework instalado.
3. Execute os scripts de criação das tabelas e stored procedures no SQL Server.
4. Configure a conexão com o banco de dados no código da camada de acesso a dados.
5. Compile e execute a aplicação.

## Como Contribuir

Se desejar contribuir para este projeto, siga as etapas abaixo:

1. Faça um fork deste repositório.
2. Crie uma branch para a sua funcionalidade/correção: `git checkout -b minha-feature`
3. Realize as alterações desejadas e faça commits: `git commit -m 'Minha nova funcionalidade'`
4. Faça push para a branch: `git push origin minha-feature`
5. Abra um Pull Request neste repositório.

## Autor

Este projeto foi desenvolvido por Francine dos Santos.

## Licença

Este projeto está licenciado sob a [Licença XYZ]. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.

---

<h1>Contextualização Projeto Hospital Uniclass - Banco de Dados Relacional</h1>

<p>Este repositório contém o trabalho desenvolvido no âmbito da disciplina de Seminário Interdisciplinar do curso de Análise e Desenvolvimento de Sistemas da Universidade UNIASSELVI. O projeto tem como foco a aplicação dos conceitos de Banco de Dados Relacional em um contexto de Clínica Hospitalar, explorando a importância desse modelo para a gestão eficiente de informações na área da saúde.
</p>

<h3>Introdução</h3>
<p>Este trabalho surge como resultado de extensas análises e reflexões realizadas durante a disciplina de Seminário Interdisciplinar. A principal meta foi compreender e apresentar de forma clara e concisa o conceito de Banco de Dados e seu modelo Relacional, aplicando-os em um cenário prático relacionado a uma Clínica Hospitalar. As informações aqui presentes foram embasadas por diversas referências bibliográficas confiáveis.</p>


<h3>Objetivos</h3>


O objetivo central deste projeto é destacar a relevância do modelo de Banco de Dados Relacional na gestão de informações dentro de uma instituição de saúde. O trabalho explora as vantagens desse modelo para solucionar problemas relacionados ao armazenamento e organização de dados, especialmente em um contexto onde a precisão e a eficiência são cruciais, como é o caso de uma Clínica Hospitalar.

<h3>Conteúdo do Projeto</h3>
<p>O projeto compreende as seguintes etapas:

<strong>Definição de Conceitos:</strong> Inicialmente, são abordados os conceitos fundamentais de Banco de Dados e do modelo Relacional, estabelecendo uma base sólida para compreensão.

<strong>Contextualização na Saúde:</strong> O foco é direcionado para a aplicação dos conceitos em um ambiente de Clínica Hospitalar. São discutidas as necessidades específicas desse contexto e como o modelo Relacional pode atender a essas demandas.

<strong>Importância do Modelo Relacional:</strong> Nesta seção, é explorada a importância crescente do modelo Relacional em um mundo cada vez mais orientado a dados. São apresentados argumentos que evidenciam por que esse modelo continua relevante e eficaz.

<strong>Discussão sobre Avanços:</strong> Com base no entendimento do modelo Relacional, abre-se uma discussão sobre possíveis avanços futuros na área de Banco de Dados, especialmente impulsionados por estudos como este.</p>


<h3>Contato</h3>
<p>Em caso de dúvidas ou interesse em discutir aspectos deste projeto, você pode entrar em contato comigo, meu email esta disponivel no perfil do meu GitHub

Agradecemos pelo interesse neste projeto e esperamos que as informações aqui contidas sejam esclarecedoras e inspiradoras para quem busca compreender a importância do modelo de Banco de Dados Relacional em um contexto de saúde.</p>


<h1>Universidade UNIASSELVI - Curso de Análise e Desenvolvimento de Sistemas</h1>

