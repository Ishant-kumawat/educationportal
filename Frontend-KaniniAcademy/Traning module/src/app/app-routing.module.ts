import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TrainingDetailsComponent } from './trainingdetails/trainingdetails.component';
import { TrainingComponent } from './training/training.component';
import { TestComponent } from './test/test.component';
import { TrainingandCertificatesComponent } from './trainingand-certificates/trainingand-certificates.component';
import { SignupComponent } from './components/signup/signup.component';
import { LoginComponent } from './components/login/login.component';
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
import { FreeresourceNavbarComponent } from './freeresource-navbar/freeresource-navbar.component';
import { DetailsComponent } from './details/details.component';
import { AboutComponent } from './about/about.component';
import { WorksComponent } from './works/works.component';
import { FirstPageComponent } from './first-page/first-page.component';
import { ViewsecondComponent } from './viewsecond/viewsecond.component';
import { PopupComponent } from './popup/popup.component';
import { UserexpcoursesComponent } from './userexpcourses/userexpcourses.component';
import { ViewcourseComponent } from './viewcourse/viewcourse.component';
import { ReviewComponent } from './review/review.component';
import { ForgotUserComponent } from './components/forgot-user/forgot-user.component';
import { ViewallnotesComponent } from './viewallnotes/viewallnotes.component';
import { AuthGuard } from './authguard/auth.guard';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent, data: { breadcrumb: 'Login' } },
  { path: 'signup', component: SignupComponent, data: { breadcrumb: 'Signup' } },
  { path: 'forgot-user', component: ForgotUserComponent },
  { path: 'Home', component: HomeComponent,data: { breadcrumb: 'Home' } },
  { path: 'Courses', component: Component1Component,canActivate:[AuthGuard], data: { breadcrumb: 'Courses' } },
  { path: 'Blogs', component: PopupComponent,canActivate:[AuthGuard], data: { breadcrumb: 'popup' } },
  { path: 'freeresources-navbar' , component: FreeresourceNavbarComponent,canActivate:[AuthGuard], data : {breadcrumb: 'Free Resources'}},

  { path: 'first-page', component: FirstPageComponent,canActivate:[AuthGuard], data: { breadcrumb: 'first-page' } },
  { path:'viewsecond',component:ViewsecondComponent,canActivate:[AuthGuard],data: { breadcrumb: 'viewsecond' }},  { path: 'freeresource-navbar', component: FreeresourceNavbarComponent, data: { breadcrumb: 'Free Resources' } },

  { path: 'Quiz', component: SkillquizComponent,canActivate:[AuthGuard], data: { breadcrumb: 'Quiz' } },
  { path: 'Faq', component: FaqComponent,canActivate:[AuthGuard], data: { breadcrumb: 'FAQ' } },
  {
    path: 'all', component: AllComponent,canActivate:[AuthGuard], data: { breadcrumb: 'All' }, children: [
      { path: 'templates', component: TemplatesComponent, data: { breadcrumb: 'Templates' } },
      { path: 'plugins', component: PluginsComponent, data: { breadcrumb: 'Plugins' } },
      { path: 'booksand-pdfs', component: BooksandPdfsComponent, data: { breadcrumb: 'Books and PDFs' } },
    ]
  },
  { path: 'Courses/continue1', component: Continue1Component, data: { breadcrumb: 'Courses/continue1' } },
  { path: 'Courses/userexpcourses', component: UserexpcoursesComponent, data: { breadcrumb: 'Courses/userexpcourses' } },
  {path:'Courses/userexpcourses/viewcourse',component:ViewcourseComponent,data:{breadcrumb:'Courses/userexpcourses/viewcourse'}},
  {path:'Courses/userexpcourses/viewcourse/component1',component:Component1Component,data:{breadcrumb:'Courses/userexpcourses/viewcourse/component1'}},
  {path:'Courses/continue1/viewallnotes',component:ViewallnotesComponent,data:{breadcrumb:'Courses/continue1/viewallnotes'}},


  {
    path: 'TrainingCertificate', component: TrainingandCertificatesComponent, data: { breadcrumb: 'Training and Certificates' }, 
    children:
    [
       { path: '', redirectTo: 'Training', pathMatch: 'full' },
      { path: 'Training', component: TrainingComponent,canActivate:[AuthGuard], data: { breadcrumb: 'Training' }},
      { path: 'Certificate', component: CertificateComponent,canActivate:[AuthGuard], data: { breadcrumb: 'Certificate' }}
    ]
  },
  { path: 'TrainingDetails/:id', component: TrainingDetailsComponent, data: { breadcrumb: 'Training Details' } },

  {
    path: 'details/:id', component: DetailsComponent, data: { breadcrumb: 'Details' }, children:
    [
      { path: '', redirectTo: 'about', pathMatch: 'full' },
      { path: 'about', component: AboutComponent, data: { breadcrumb: 'About' } },
      { path: 'works', component: WorksComponent, data: { breadcrumb: 'Works' } },
      { path: 'faq', component: FaqComponent, data: { breadcrumb: 'FAQ' } }
    ]
  },


  { path: 'downloadpage/:freeRid', component: DownloadpageComponent, data: { breadcrumb: 'Download Page' } },
  {path:'review',component:ReviewComponent, data:{breadcrumb:'All reviews'}}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]   
})
export class AppRoutingModule { }
export const routingComponents = [TrainingDetailsComponent]
