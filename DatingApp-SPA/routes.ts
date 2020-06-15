import {Routes} from '@angular/router';
import { HomeComponent } from 'src/app/home/home.component';
import { MemberListComponent } from 'src/app/member-list/member-list.component';
import { MessagesComponent } from 'src/app/messages/messages.component';
import { ListsComponent } from 'src/app/lists/lists.component';
import { AuthGuard } from 'src/app/_guards/auth.guard';

export const appRoutes: Routes = [
    {path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
        {path: 'members', component: MemberListComponent},
        {path: 'messages', component: MessagesComponent},
        {path: 'list', component: ListsComponent},
        ]
    },
    {path: '**', redirectTo: 'home', pathMatch: 'full'},
];
