import { Component, OnInit } from '@angular/core';
import { EventoService } from '../evento.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  public eventos: any[] = [];
  public eventosOriginal: any[] = [];
  larguraImagem: number = 200;
  marginImagem: number = 20;
  mostrarImagem: boolean = true;
  filtroLista: string = '';

  constructor(private eventoService: EventoService) { }

  ngOnInit(): void {
    this.getEventos();

  }

  public getEventos(): void {
    this.eventoService.getEventos().subscribe(
      response => {
        this.eventos = response;
        this.eventosOriginal = [...this.eventos];
      },
      error => console.log(error)
    );
  }
  AlterarImagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  FiltroLista() {
    if (this.filtroLista.trim() !== '') {

     const filtroPalavras = this.removerAcentos(this.filtroLista.toLowerCase());
       this.eventos = this.eventosOriginal.filter(evento => {
        const tema = this.removerAcentos(evento.tema.toLowerCase());
        const local = this.removerAcentos(evento.local.toLowerCase());

        return (

          tema.includes(filtroPalavras) ||
          local.includes(filtroPalavras)

        );
      });

    } else {

      this.eventos = [...this.eventosOriginal];
    }
  }

  private removerAcentos(str: string): string {
    return str.normalize('NFD').replace(/[\u0300-\u036f]/g, '');
  }


}


