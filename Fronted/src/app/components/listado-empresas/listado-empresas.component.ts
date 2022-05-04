import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listado-empresas',
  templateUrl: './listado-empresas.component.html',
  styleUrls: ['./listado-empresas.component.scss']
})
export class ListadoEmpresasComponent implements OnInit {
  empresas: any[] = [
    {nombre:'Vidri',representante:'Juan peréz',rubro:'Papeleria'},
    {nombre:'Siman',representante:'Siman',rubro:'Muebles'},
    {nombre:'Prado',representante:'Nieto',rubro:'Electrodomesticos'}
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
