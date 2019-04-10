import { Component, OnInit } from '@angular/core';
import { AirplaneService } from 'src/app/service/airplane.service';
import { AirPlane } from 'src/app/model/airplane.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-list-airplane',
  templateUrl: './list-airplane.component.html',
  styleUrls: ['./list-airplane.component.css']

})
export class ListAirplaneComponent implements OnInit {

  airplanes: AirPlane[];
  constructor(private airplaneService: AirplaneService, private router: Router) { }

  ngOnInit() {
    this.get();
  }

  get(): void {
    this.airplaneService.getAirPlanes()
    .subscribe( data => {
      this.airplanes = data;
    });
  }

  edit(airplane: AirPlane): void {
      this.router.navigate(['edit-airplane'], { queryParams: { id: airplane.id.toString() } });
  }

  delete(airplane: AirPlane): void {
    this.airplaneService.deleteAirplane(airplane.id)
      .subscribe( data => {
        this.get();
      });
  }

  add(): void {
    this.router.navigate(['add-airplane']);
  }

}
