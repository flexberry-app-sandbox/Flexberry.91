import { Serializer as ЗаписиSerializer } from
  '../mixins/regenerated/serializers/i-i-s-9-записи';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ЗаписиSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
