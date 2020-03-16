import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../services/Service.service';
import { ObrasBibliograficasComponent } from '../ObrasBibliograficas/ObrasBibliograficas.component';

@Component({
  selector: 'app-NomesAutores',
  templateUrl: './NomesAutores.component.html',
  styleUrls: ['./NomesAutores.component.css']
})
export class NomesAutoresComponent implements OnInit {
  
  constructor(private service: ServiceService) { }
  
  ngOnInit() {
  }
  
  public nomesInseridos: any = [];
  public nomesInseriosTratados: any = [];
  public componentObra :ObrasBibliograficasComponent;
  
  public numNomes: number;
  criarForms(numNome : number){
    let template = ``;
    for(let i=1; i <= numNome; i++){
      template += `
      <div class="form-group row">
      <label for="colFormLabel" class="col-sm-2 col-form-label">Nome:</label>
      <div class="col-sm-6">
      <input type="text" class="form-control nomesAutores" .nomes placeholder="Informe o Nome">
      </div>
      </div>
      `
    }
    
    document.querySelector('#formularioAutores').innerHTML = template;
    (<HTMLElement>document.querySelector('#salvarNomes')).style.display = '';
    (<HTMLElement>document.querySelector('#nomesFormatados')).style.display = 'none';

  }
  
  salvarNomes(){
    
    let camposNomes = (document.querySelectorAll('.nomesAutores') as any);
    let nomes = [];
    this.nomesInseridos = [];
    this.nomesInseriosTratados = [];
    
    camposNomes.forEach(item => nomes.push(item.value));
    
    nomes.forEach(item =>{
      let json = {'nomeAutor': item};
      this.service.setAutor(json).subscribe(resposta =>{
        this.nomesInseridos.push(resposta);
        
      })
    })
    
    setTimeout(()=>{
      this.aplicaTratamentoNomes();
      document.querySelector('#formularioAutores').innerHTML = '';
      (<HTMLElement>document.querySelector('#salvarNomes')).style.display = 'none';
      (<HTMLElement>document.querySelector('#nomesFormatados')).style.display = '';
    },1000);
    
    
  }
  
  aplicaTratamentoNomes(){
    let nome = '';
    this.nomesInseridos.forEach((item)=>{
      nome = this.trataNomes(item.nomeAutor);
      this.nomesInseriosTratados.push({'nome': nome});
    })
  }
  
  trataNomes(getNome){
    let partesNomes = getNome.split(' ');
    let nomeAtual = '';
    let nome = '';
    let penultimoNome = '';
    let ultimaPosicao = partesNomes.length - 1;
    let ultimoNome = partesNomes[ultimaPosicao].toUpperCase();
    
    if(ultimoNome == 'FILHO' || ultimoNome == 'FILHA' || ultimoNome == 'NETO' || ultimoNome == 'NETA' || ultimoNome == 'SOBRINHO' || ultimoNome == 'SOBRINHA' || ultimoNome == 'JUNIOR'){
      
      let penultimaPosicao = ultimaPosicao -1;
      partesNomes.forEach((nomeAutor,index) =>{
        if(index == ultimaPosicao){
          nome = `${penultimoNome.toUpperCase()} ${nomeAutor.toUpperCase()},${nomeAtual}`;
          nomeAtual = nome;
          nome = '';
        } 
        else if(index == penultimaPosicao ){
          penultimoNome = nomeAutor;
          nome = '';
        }
        else {
          nome += `${nome} ${nomeAutor}`;
          nomeAtual += nome;
          nome = '';
        }
      })
      return nomeAtual
    } 
    
    if(partesNomes.length == 1 ){
      return partesNomes[0].toUpperCase();
    }
    
    
    partesNomes.forEach((item,index) =>{
      if(index == ultimaPosicao){
        nome = `${item.toUpperCase()},${nomeAtual}`;
        nomeAtual = nome;
        nome = '';
      } else {
        nome += `${nome} ${item}`;
        nomeAtual += nome;
        nome = '';
      }
    })
    return nomeAtual
  }
  
}
