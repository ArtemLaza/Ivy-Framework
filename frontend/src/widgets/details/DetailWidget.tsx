import { cn } from '@/lib/utils';
import React from 'react';

interface DetailWidgetProps {
  id: string;
  label: string;
  multiLine?: boolean;
  children?: React.ReactNode[];
}

export const DetailWidget: React.FC<DetailWidgetProps> = ({
  id,
  label,
  children,
  multiLine,
}) => {
  return (
    <div className={cn('border-b flex items-center')} key={id}>
      <div
        className={cn(
          'p-3 pl-0 align-middle text-body font-bold',
          !multiLine && 'whitespace-nowrap overflow-hidden text-ellipsis'
        )}
      >
        {label}
      </div>
      <div
        className={cn(
          'align-middle text-body text-right ml-auto p-3 pl-2 pr-0 min-w-0',
          multiLine && 'max-w-[500px]',
          !multiLine && 'whitespace-nowrap max-w-[300px]'
        )}
      >
        {children}
      </div>
    </div>
  );
};
