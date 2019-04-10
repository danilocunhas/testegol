import {Routes} from '@angular/router';
import { ListAirplaneComponent } from './components/list-airplane/list-airplane.component';
import { EditAirplaneComponent } from './components/edit-airplane/edit-airplane.component';
import { AddAirplaneComponent } from './components/add-airplane/add-airplane.component';

export const ROUTES: Routes = [
    {path: '', component: ListAirplaneComponent},
    {path: 'edit-airplane', component: EditAirplaneComponent},
    {path: 'add-airplane', component: AddAirplaneComponent},
    {path: 'list-airplane', component: ListAirplaneComponent}
];
