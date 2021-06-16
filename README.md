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

<h3><li>Concatenação de strings</h3>
<p>O exemplo abaixo demonstra os testes utilizando diferentes comandos de concatenação e interpolação de strings.
  
  ![Screenshot_2](https://user-images.githubusercontent.com/35710766/122084857-93215f80-cdd8-11eb-874b-68e3724a9d53.png)
  
  </br>
  
  Resultado:
  
  ![Screenshot_3](https://user-images.githubusercontent.com/35710766/122085107-ca900c00-cdd8-11eb-8447-39c672202020.png)
  
  Diante desse resultado, percebe-se que utilizando ```string.format()``` leva tempo relativamente maior do que utilizar operações básicas de concatenação com ```+```, template string e ```StringBuilder``` para modificar a mesma referência de objeto de string.
</p>
</li>

</br>

<h3><li>Casting</h3>

<p>Nesta seção, são demonstrados os testes de performance utilizando diferentes comandos de casting de tipos, conforme o exemplo abaixo:

  ![Screenshot_3](https://user-images.githubusercontent.com/35710766/122086238-e647e200-cdd9-11eb-8cc7-eabf26cf7a14.png)
  
  </br>
  
  Na imagem acima foi inicializado um array de strings com a chamada do ```Setup``` que ocorre apenas uma única vez. Da mesma forma que foram realizados testes da seção 1, foram considerados dois cenários de testes: um com array de 1000 elementos, e outro de 10000.
  
  </br>
  
  Resultado:
  
  ![Screenshot_4](https://user-images.githubusercontent.com/35710766/122086672-522a4a80-cdda-11eb-9443-df08d284a8ef.png)

  De acordo com a imagem acima, percebe-se que para tamanhos pequenos de coleções, a diferença de performance é imperceptível, mas à medida que um array cresce, os valores começam a ficar discrepantes. Percebe-se que utilizando ```TryParse```, obteve resultados relativamente melhores do que se utilizar ```Convert``` e ```Parse```.
</p>
</li>

</br>

<h3><li>Serialização e desesialização de JSON</h3>

<p>Nesta seção, são demonstrados os testes de performance de serialização e deserialização de objetos JSON utilizando Newtonsoft e JsonSerializer

![Screenshot_4](https://user-images.githubusercontent.com/35710766/122139319-1796d100-ce1f-11eb-8b5e-12d9a6a47f74.png)

 </br>
 
 Resultado:
 
 ![Screenshot_5](https://user-images.githubusercontent.com/35710766/122139659-dbb03b80-ce1f-11eb-9bf9-99c9e9b29892.png)

  A performance do ```JsonSerializer``` gerou melhores resultados do que ```Newtonsoft```
  
</p>
</ol>  
    
     



