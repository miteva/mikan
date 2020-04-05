import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-machine',
  templateUrl: './add-machine.component.html'
})
export class AddMachineComponent {
  public machine: Machine = {
    name: '',
    description:''
  };

  constructor(private http: HttpClient) {
 }

  add() {

    this.http.post('machine/add', this.machine).subscribe();
  }
}

interface Machine {
  name: string;
  description: string;
}
