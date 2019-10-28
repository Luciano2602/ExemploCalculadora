import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { CalculadoraComponent } from './calculadora.component';
import { CalculadoraService } from './calculadora.service';

@NgModule({
    declarations: [
        CalculadoraComponent
    ],
    imports: [
        HttpClientModule,
        CommonModule,
        FormsModule
    ],
    exports: [
        CalculadoraComponent
    ],
    providers: [
        CalculadoraService
    ]
})
export class CalculadoraModule {}
