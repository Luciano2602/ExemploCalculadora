import { Component } from '@angular/core';
import { OperacaoEnum } from './operacao.enum';
import { CalculadoraViewModel } from './calculadora.vm';
import { CalculadoraService } from './calculadora.service';
import { Result } from './result';

@Component({
  selector: 'sl-calculadora',
  templateUrl: './calculadora.component.html'
})
export class CalculadoraComponent {

  public calculadora = new CalculadoraViewModel();

  operacoes = [
    { Id: OperacaoEnum.Adicao, Operacao: 'Adição', Sinal: '+' },
    { Id: OperacaoEnum.Divisao, Operacao: 'Divisão', Sinal: '/' },
    { Id: OperacaoEnum.Subtracao, Operacao: 'Subtração', Sinal: '-' },
    { Id: OperacaoEnum.Multiplicacao, Operacao: 'Multiplicação', Sinal: 'X' },
  ];

  constructor(private calculadoraService: CalculadoraService) { }

  calcular(): void {
    if (!this.validarParametros()) { return; }

    this.calculadoraService.calcular(this.calculadora).subscribe(
      (result: Result<CalculadoraViewModel>) => {
        this.calculadora = result.Data;
        const operacaoSelecionada = this.operacoes.find(x => x.Id == this.calculadora.Operacao);

        alert(
          this.calculadora.Numero1 + ' ' +
          operacaoSelecionada.Sinal + ' ' +
          this.calculadora.Numero2 + ' = ' + this.calculadora.Resultado
        );
      },
      (error) => alert('Erro: ' + error)
    );
  }

  validarParametros(): boolean {
    return this.calculadora.Numero1 > 0 &&
      this.calculadora.Numero2 > 0 &&
      this.calculadora.Operacao > 0;
  }
}
