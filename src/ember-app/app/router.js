import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-9-должности-l');
  this.route('i-i-s-9-должности-e',
  { path: 'i-i-s-9-должности-e/:id' });
  this.route('i-i-s-9-должности-e.new',
  { path: 'i-i-s-9-должности-e/new' });
  this.route('i-i-s-9-записи-l');
  this.route('i-i-s-9-записи-e',
  { path: 'i-i-s-9-записи-e/:id' });
  this.route('i-i-s-9-записи-e.new',
  { path: 'i-i-s-9-записи-e/new' });
  this.route('i-i-s-9-заявка-l');
  this.route('i-i-s-9-заявка-e',
  { path: 'i-i-s-9-заявка-e/:id' });
  this.route('i-i-s-9-заявка-e.new',
  { path: 'i-i-s-9-заявка-e/new' });
  this.route('i-i-s-9-контрагент-l');
  this.route('i-i-s-9-контрагент-e',
  { path: 'i-i-s-9-контрагент-e/:id' });
  this.route('i-i-s-9-контрагент-e.new',
  { path: 'i-i-s-9-контрагент-e/new' });
  this.route('i-i-s-9-регистр-l');
  this.route('i-i-s-9-регистр-e',
  { path: 'i-i-s-9-регистр-e/:id' });
  this.route('i-i-s-9-регистр-e.new',
  { path: 'i-i-s-9-регистр-e/new' });
  this.route('i-i-s-9-сотрудник-l');
  this.route('i-i-s-9-сотрудник-e',
  { path: 'i-i-s-9-сотрудник-e/:id' });
  this.route('i-i-s-9-сотрудник-e.new',
  { path: 'i-i-s-9-сотрудник-e/new' });
});

export default Router;
