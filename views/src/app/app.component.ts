import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ParentDataComponent } from "./components/parent-data/parent-data.component";
import { ListComponent } from './components/list/list.component';


@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, ParentDataComponent,ListComponent]
})
export class AppComponent {
    name = "japa";
}
