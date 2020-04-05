import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-machine',
  templateUrl: './machine.component.html'
})
export class MachineComponent {
  public machines: Machine[];
  public machine: Machine = {
    name: '',
    description:''
  };

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Machine[]>(baseUrl + 'machine/index').subscribe(result => {
      this.machines = result;
    }, error => console.error(error));
  }

}

interface Machine {
  name: string;
  description: string;
}
