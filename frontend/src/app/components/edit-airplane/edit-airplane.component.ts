import { Component, OnInit } from '@angular/core';
import { AirplaneService } from 'src/app/service/airplane.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-airplane',
  templateUrl: './edit-airplane.component.html'
})
export class EditAirplaneComponent implements OnInit {

  editForm: FormGroup;
  airplaneId: number;

  constructor(private formBuilder: FormBuilder, private router: Router,
    private airplaneService: AirplaneService, private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.editForm = this.formBuilder.group({
      id: [],
      code: ['', Validators.required],
      model: ['', Validators.required],
      numberOfPassengers: ['', Validators.required],
      createdDate: []
    });

    this.activatedRoute.queryParams.subscribe(params => {
      this.airplaneId = params.id;
    });

    this.airplaneService.getAirPlanesById(this.airplaneId)
      .subscribe(data => {
        this.editForm.setValue(data);
      });
  }

  onSubmit() {
    this.airplaneService.updateAirplane(this.editForm.value)
      .subscribe(
        data => {
          this.router.navigate(['list-airplane']);
        });
  }
}
