# MeasuringPerformance.NET

<p>Aplicação construída para fins de estudos sobre fundamentos de performance em .NET. Ela consiste em realizar testes de benchmark de cada comando que é comumente utilizado no dia-a-dia dos desenvolvedores .NET. Vale ressaltar que isso não implica em convencer o desenvolvedor de mudar a forma de escrever o código só para buscar o famigerado "código perfeito". Isso depende de cenários de projetos que demandam ou não a performance. Além disso, geralmente é preciso se preocupar com a performance quando o tamanho de uma estrutura de dados ou de uma coleção for consideravelmente grande, ou que tenha muitos dados. Em situações mais triviais, muitas vezes a diferença de performance é praticamente imperceptível.</p>

---

<h2>Testes</h2>

<ol>
  <h3><li>Laços de repetição</h3>
    <p>O exemplo a seguir demonstra um programa simples que percorre os 100 primeiros elementos inteiros gerados aleatoriamente numa coleção, e ao final do laço, retorna um somatório de todos eles. Foram considerados dois cenários de teste distintos: um para coleções de 1000 elementos, e outro de 10000. Foram testados com Array, List e IEnumerable.</p>

  ![Screenshot_6](https://user-images.githubusercontent.com/35710766/121976250-d2f53200-cd59-11eb-96ab-ca770c366cd4.png)

  </br>

  ![Screenshot_1](https://user-images.githubusercontent.com/35710766/121976354-0637c100-cd5a-11eb-8042-59776c16329d.png)
  
  </br>
  
  Abaixo estão os resultados dos benchmarks. Foram realizados testes com os comandos ```for```, ```foreach``` e com o método ```ForEach()``` do LINQ, um para cada tipo de coleção:
  
  ![Screenshot_5](https://user-images.githubusercontent.com/35710766/121980555-83ffca80-cd62-11eb-9d2a-ef7a350b799a.png)

  </li>
  
  </br>
  
  <h3><li>Comparação de strings</h3>
  <p> O exemplo abaixo demonstra os testes de comparação de strings, um comparando com uma string em caixa alta, outro em caixa baixa e, por último, sem considerar a sensibilidade de caixa.
  
  ![Screenshot_2](https://user-images.githubusercontent.com/35710766/121981229-a9d99f00-cd63-11eb-8e69-90b01f7391cc.png)
  
  </br>
  
  Resultado:
  
  ![Screenshot_1](https://user-images.githubusercontent.com/35710766/121981378-eb6a4a00-cd63-11eb-8d4a-fe740111074d.png)

  Percebe-se que utilizando ```String.Comparison.OrdinalIgnoreCase``` para ignorar a sensibilidade de caixa, obteve-se a performance relativamente melhor.
</p>
</li>

</br>
  
</ol>  
    
     



