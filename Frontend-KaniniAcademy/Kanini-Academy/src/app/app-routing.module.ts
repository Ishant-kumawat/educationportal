import { SignupComponent } from './components/signup/signup.component';
import { LoginComponent } from './components/login/login.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { CertificateComponent } from './certificate/certificate.component';
import { SkillquizComponent } from './skillquiz/skillquiz.component';
import { HomeComponent } from './home/home.component';
import { AllComponent } from './all/all.component';
import { BlogComponent } from './blog/blog.component';
import { DownloadpageComponent } from './downloadpage/downloadpage.component';
import { BooksandPdfsComponent } from './booksand-pdfs/booksand-pdfs.component';
import { TemplatesComponent } from './templates/templates.component';
import { PluginsComponent } from './plugins/plugins.component';
import { ResourceNavbarComponent } from './resource-navbar/resource-navbar.component';
import { Component1Component } from './component1/component1.component';
import { FaqComponent } from './faq/faq.component';
import { Continue1Component } from './continue1/continue1.component';
import { TrainingComponent } from './training/training.component';
import { FreeresourceNavbarComponent } from './freeresource-navbar/freeresource-navbar.component';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignupComponent },


  // Routes with the NavbarComponent
  
   { path: '',
    component: NavbarComponent},
    
      { path: 'Home', component: HomeComponent },
      { path: 'Certificate', component: CertificateComponent },
      { path: 'Courses', component: Component1Component },
      { path: 'Blogs', component: BlogComponent },
      { path: 'freeresource-navbar', component: FreeresourceNavbarComponent},
      { path: 'Quiz', component: SkillquizComponent },
      { path: 'Faq', component: FaqComponent },
      {
        path: 'all', component: AllComponent, children: [
          { path: 'templates', component: TemplatesComponent },
          { path: 'plugins', component: PluginsComponent },
          { path: 'booksand-pdfs', component: BooksandPdfsComponent },
          { path: 'templates', component: TemplatesComponent },
        ]
      },
      { path: 'continue1', component: Continue1Component },
      { path: 'Training', component: TrainingComponent },
      { path: 'downloadpage', component: DownloadpageComponent },
    ];
  

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
