<h1 align="center"><u>Notações e desenvolvimento de uma UML</u></h1>

<h2>Modelo de visões</h2>
<p>
Temos que os sistemas são cmpostos por modelos qe traduzem pontos de vista distintos, em que cada um detalha alguma particlaridade da mesma solução. Tas pontos são chamados de <b>visões</b>, focados no mesmo sistema, poém sob óticas diferentes.
</p>
<ul>
    <li>
    <b>Visão de caso de uso:</b> acordo entre cliente e programador para definir o conceito e as funçoes que o sistema deverá possuir para atender aos requisitos. 
    <a href="https://www.youtube.com/watch?v=ab6eDdwS3rA">Tutoral de Caso de Uso UML</a>
    </li>
    <li>
    <b>Visão de processo:</b> visão de como é possível compreender a estrutura dos processos do sistema. Possibilita capturar características estáticas e dinâmicas em diagramas de estado, interação e atividade.
    </li>
    <li>
    <b>Visão lógca:</b> viabiliza organizar e estruturar o desenho do sistema de modo lógico.Permite a especificação de classes, subclasses e pacotes lógicos do sistema.
    </li>
    <li>
    <b>Visão de implementação:</b> permite pegar as deliberações em relação à aquitetura para implementar no sstema, detalhando os subsistemas com suas dependêncas e seus elementos estruturados em categorias hierarquias.
    </li>
    <li>
    <b>Visão de implantação:</b> trata da distribuição física do software, viabilizada por meio de um grupo de nós do ambente em que será instalado.
    </li>
</ul>

<p>
Primeiramente detalham-se as funcionalidades e os requisitos a partir da visão de caso de uso, sem se atentar quanto à tecnologia, ao banco de dados, ao servidor ou à linguagem a ser utilizada em um primeiro momento, pois o primodial é detalhar o máximo possível a solução que o cliente quer. Uma vez definda essa parte, passa-se para as demais visões, finalizando com a implantação.
</p>

<h2>Blocos de construção</h2>
<ul>
    <li>
    <b>Itens:</b> referem-se às abstrações distinguidas como cidadãos de primeira classe em um mocelo.
    </li>
    <li>
    <b>Relacionamentos:</b> são as conexões que unem os itens.
    </li>
    <li>
    <b>Diagramas:</b> servem para agrupar coleções interessantes de itens.
    </li>
</ul>
<h3>Itens da UML</h3>
<p>
Os itens são blocos de construção basicos orientados a objetos da UML, os quaiis são utlizados para detalhar modelos bem formados.
</p>

<h4>Itens estrutrais</h4>
<p>
São relacionados aos substantivos aplicados em modelagem ML. No modelo, são consideradas as partes mais estáticas, podendo retratar componentes físicos ou conceituais.
</p>
<ul>
    <li>
    <b>Classes:</b> detalhamentos de grupos de objetos que dividem operações, atributos, semântica e relacionamentos iguais, podendo desenvolver uma ou mais interfaces. Os retângulos dizem respeito à sua especificação gráfica. Representadas por retângulos.
    </li>
    <li>
    <b>Interface:</b> conjunto de operações que detalham os serviçoes de um componente ou uma classe, descrevendo comportamentos externos visíveis e podendo representar todos os comportamntos de um componente ou uma classe. Geralmente,  não aparecem sozinhas. Graficamente, podem aparecer como círculos se forem providas por uma classe ao mundo externo, ligados por uma linha. Caso sejam providas por outro tipo de classe, aparecem como semicírculos anexados à caixa de classes, ligados por uma linha.
    </li>
    <li>
    <b>Colaboraçẽos:</b> determinam as interações. São sociedades de papéis e outros componentesque trabalham em conjunto para possibilitar um comportamento cooperativo superior à soma de todos os componentes. São representadas por elipses com linhas tracejadas que, de modo geral, trazem somente seus nomes.
    </li>
    <li>
    <b>Caso de uso:</b> detalha a sequência de atividades realizadas pelo sistema, providenciando resultados visíveis de valor para determinado ator. São representados por uma elipse com linhas contíbuas que também trazem somente seus nomes.
    </li>
    <li>
    <b>Classes ativas:</b> são classes em qe objetos possuem um ou mais processos(threads), podendo iniiciar a atividade de controle. São parecidas com uma classe, diferenciando-se por seus objetos retratarem elementos dos qais o comportamento é concorrente com outros elmentos. São representadas por retângulos, porém com linhas duplas.
    </li>
    <li>
    <b>Componentes:</b> São partes modulares sistêmicas que escondem o seu desenvolvimento atrás de um grupo de interfaces externas. Aqueles que dividem as mesmas interfaces podem ser trocados ao mesmo tempo em que mantêm o comportamento lógico. São retratados, graficamente, como uma classe com um ícone especial no canto superior direito.
    </li>
    <li>
    <b>Nó:</b> componente físco que existe no tempo de execução e reproduz um recurso computacional com alguma memória e capacidade de processamento. Um conjunto de componentes poderá estar integrado em um nó, assim como mover de um nó para outro. Representado por um cubo.
    </li>
</ul>
<h4>Itens comportamentais</h4>
<p>
Referem-se os verbos de um modelo, os quais representam os compotamentos no espaço e tempo. São considerados a parte dinâmica da UML.
</p>
<ul>
    <li>
    <b>Interação:</b> comportamento que engloba um gupo de mensagens trocadas entre um grupo de objetos, em alguma circunstância, para realizar propósitos específicos. São retratadas por uma lina cheia com seta, normalmente contendo o nome d suas operações.
    </li>
    <li>
    <b>Máquina de estado:</b> comportamento que detalha as sequências de estados dos qais interações ou objetos percorrem durante sua existência em resposta a eventos. Retratada por um retângulo com ângulos arredondados, gealmente contendo o nome e o respectivo subestado, se tiver.
    </li>
    <li>
    <b>Atividade:</b> comportamento que detalha a sequência de etapas que um processo computacional executa. É retratada por um retângulo com ângulos arredondados, juntamente com o nome que indica a sua finalidade.
    </li>
</ul>

<h3>Itens de agrupamento</h3>