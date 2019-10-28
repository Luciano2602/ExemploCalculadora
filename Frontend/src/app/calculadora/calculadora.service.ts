import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { CalculadoraViewModel } from './calculadora.vm';
import { Result } from './result';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root'
})
export class CalculadoraService {
    // private API =  `${environment.API}/calculadora`;
    private API =  `http://localhost:50001/api/calculadora`;

    constructor(private http: HttpClient) { }

    calcular(calculadora: CalculadoraViewModel): Observable<Result<CalculadoraViewModel>> {
        return this.http.post<Result<CalculadoraViewModel>>(this.API, calculadora);
    }
}
