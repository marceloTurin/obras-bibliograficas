import { Injectable } from '@angular/core';
import { HttpClient,HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

    httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }

  constructor(private http: HttpClient) { }

  public getObras(): Observable<any>{
    return this.http.get('http://localhost:4200/api/api/ObrasBibliograficas');
  }

  public setAutor(nome: any) {
    return this.http.post('http://localhost:4200/api/api/ObrasBibliograficas',nome);
  }

}
