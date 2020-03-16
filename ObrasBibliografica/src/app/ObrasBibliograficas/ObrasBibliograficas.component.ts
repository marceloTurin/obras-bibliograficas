import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../services/Service.service';

@Component({
  selector: 'app-ObrasBibliograficas',
  templateUrl: './ObrasBibliograficas.component.html',
  styleUrls: ['./ObrasBibliograficas.component.css']
})
export class ObrasBibliograficasComponent implements OnInit {
  
  constructor(private service: ServiceService) { }
  
  ngOnInit() {
    this.getterObras();
    setTimeout(()=>{
      this.aplicaTratamentoNomes();
    },1000); 
  }
  
  obrasBibliograficas: any = [];
  autoresNomes: any = [];
  
  getterObras(){
    this.service.getObras().subscribe(
      data =>{
        this.obrasBibliograficas = data
      }, 
      error =>{
        console.log(error);  
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
    
    aplicaTratamentoNomes(){
      let nome = '';
      this.obrasBibliograficas.forEach((item)=>{
        nome = this.trataNomes(item.nomeAutor);
        this.autoresNomes.push({'nome': nome});
      })
    }
    
  }
  
  